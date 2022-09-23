export class AuthModel {
  success: boolean;
  message: string;
  data: APIData;
}
export interface APIData {
  expiration: string;
  token: string;
}
