export type IAdminLoginResponse = {
  id: string;
  username: string;
  email: string;
  displayName: string;
  role: string;
  status: AdminRoles;
  phoneNumber?: string;
  address?: string;
  updatedAt?: string;
  accessToken: string;
  accessTokenExpiredIn: number;
  refreshToken: string;
  refreshTokenExpiredIn: number;
};

export type ITokenUnion = "accessToken" | "accessTokenExpiredIn" | "refreshToken" | "refreshTokenExpiredIn";

export type IAdmin = Omit<IAdminLoginResponse, ITokenUnion>;

export type IAuth = {
  accessToken: string;
  accessTokenExpiredDate: string;
  refreshToken: string;
  refreshTokenExpiredDate: string;
};

export enum AdminRoles {
  SalesAssociate = "SalesAssociate",
}
