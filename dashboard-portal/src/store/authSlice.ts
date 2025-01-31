import { IAdmin, IAdminLoginResponse, IAuth } from "@/types/admin";
import { useLocalStorage } from "@/utils/localStorage";
import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import dayjs from "dayjs";

interface AuthState {
  admin: IAdmin | null;
  authToken: IAuth | null;
}

const initialState: AuthState = {
  admin: null,
  authToken: null,
};

const { setItem, removeItem } = useLocalStorage();

const authSlice = createSlice({
  name: "auth",
  initialState,
  reducers: {
    login: (state, action: PayloadAction<IAdminLoginResponse>) => {
      const { accessToken, refreshToken, accessTokenExpiredIn, refreshTokenExpiredIn, ...admin } = action.payload;
      state.admin = admin;
      const authToken: IAuth = {
        accessToken: accessToken,
        accessTokenExpiredDate: dayjs().add(accessTokenExpiredIn, "seconds").toString(),
        refreshToken: refreshToken,
        refreshTokenExpiredDate: dayjs().add(refreshTokenExpiredIn, "seconds").toString(),
      };
      state.authToken = authToken;

      setItem("auth", authToken);
    },
    logout: (state) => {
      state.admin = null;
      state.authToken = null;
      removeItem("auth");
    },
  },
});

export const { login, logout } = authSlice.actions;

export default authSlice.reducer;
