import { Component, OnInit } from '@angular/core';
import { AuthService, UserModel } from '../auth';
export type User = UserModel | undefined;
@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
})
export class AccountComponent implements OnInit {
  User: User = new UserModel();
  constructor(private authService: AuthService) {}

  ngOnInit(): void {
    this.authService.getUserByToken().subscribe((data) => {
      debugger;
      if (data && this.User) {
        this.User.fullName = data.fullName;
      }

      console.log(data);
    });
  }
}
