export class AuthModel {
  success: boolean;
  message: string;
  data: APIData;

  setAuth(auth: AuthModel) {
    this.success = auth.success;
    this.message = auth.message;
    this.data = auth.data;
  }
}
export interface APIData {
  expiration: string;
  token: string;
}
