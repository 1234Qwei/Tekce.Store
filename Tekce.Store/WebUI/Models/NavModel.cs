using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Text;
using WebUI._keenthemes.libs;

namespace System.Web.MVC
{
    public class NavModel
    {
        private IKTTheme kTTheme;
        private List<Menu> Root = new List<Menu>();

        public NavModel(IKTTheme kTTheme)
        {
            this.kTTheme = kTTheme;
            Root.Add(DashBoard());


        }

        public Menu DashBoard()
        {
            var menu = new Menu("Anasayfa", "/", kTTheme.getSvgIcon("duotune/general/gen025.svg",
                                             "svg-icon svg-icon-2"));
            var mainMenu= new Menu("Anasayfa","/");
            var reports = new Menu("Raporlar","/Dashboards/Privacy");
            menu.AddChild(mainMenu);
            menu.AddChild(reports);

            return menu;

        }


        public string GetHtml()
        {
            return Recursive(Root, 0);
        }

        public string Recursive(IEnumerable<Menu> menuList, int generation)
        {
            var str = new StringBuilder();
          
            foreach (var menu in menuList)
            {

                var childrens = new StringBuilder();
                foreach (var item in menu.Children)
                {
                   
                    childrens.Append($@"
	                <!--begin:Menu item-->
					<div class=""menu-item"">
						<!--begin:Menu link-->
						<a class=""menu-link"" href=""{item.Url}"">
							<span class=""menu-bullet"">
								<span class=""bullet bullet-dot""></span>
							</span>
							<span class=""menu-title"">{item.Name}</span>
						</a>
						<!--end:Menu link-->
					</div>
					<!--end:Menu item-->            


                    ");
                  
                }

                str.Append($@"
                    <!--begin:Menu item-->
			<div data-kt-menu-trigger=""click"" class=""menu-item here show menu-accordion"">
				<!--begin:Menu link-->
				<span class=""menu-link"">
					<span class=""menu-icon"">{menu.Icon}</span>
					<span class=""menu-title"">{menu.Name}</span>
					<span class=""menu-arrow""></span>
				</span>
				<!--end:Menu link-->
				<!--begin:Menu sub-->
				<div class=""menu-sub menu-sub-accordion"">
                    
				{childrens}
				
				</div>
				<!--end:Menu sub-->
			</div>
			<!--end:Menu item-->    

                
                ");




            }


            return str.ToString();
        }


    }

    public class Menu
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public bool Blank { get; set; }
        public bool Visible { get; set; } = true;
        public List<Menu> Children { get; set; } = new List<Menu>();

        public Menu()
        {
        }

        public Menu(string Name, string Url = "#", string Icon = "", bool newBlank = false)
        {
            this.Name = Name;
            this.Url = Url;
            this.Icon = Icon;
            this.Blank = newBlank;
        }

        public void AddChild(Menu child)
        {
            Children.Add(child);
        }
    }
}