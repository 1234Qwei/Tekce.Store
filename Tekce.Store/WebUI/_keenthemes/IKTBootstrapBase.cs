using WebUI._keenthemes.libs;

namespace WebUI._keenthemes;

public interface IKTBootstrapBase
{
    void initThemeMode();
    
    void initThemeDirection();

    void initLayout();
    
    void init(IKTTheme theme);
}