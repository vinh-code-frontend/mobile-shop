import apiClient from "@/api";
import { IAdminLoginResponse, IAuth } from "@/types/admin";
import { useForm } from "react-hook-form";
import dayjs from "dayjs";
import { useLocalStorage } from "@/utils/localStorage";

type TLoginForm = {
  username: string;
  password: string;
};

const { setItem } = useLocalStorage();

const LoginPage = () => {
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<TLoginForm>();
  const onSubmit = async (formModel: TLoginForm) => {
    const res = (await apiClient.post("/admin/login", formModel)) as IAdminLoginResponse;

    const authToken: IAuth = {
      accessToken: res.accessToken,
      accessTokenExpiredDate: dayjs().add(res.accessTokenExpiredIn, "seconds").toString(),
      refreshToken: res.refreshToken,
      refreshTokenExpiredDate: dayjs().add(res.refreshTokenExpiredIn, "seconds").toString(),
    };

    setItem("auth", authToken);
  };

  return (
    <div className="flex items-center justify-center h-screen">
      <fieldset className="fieldset w-xs bg-base-200 border border-base-300 p-4 rounded-box">
        <legend className="fieldset-legend text-xl">Login</legend>

        <label className="fieldset-label required-label">Username</label>
        <input
          type="text"
          className="input"
          placeholder="Enter your username"
          {...register("username", { required: "Username is required" })}
        />
        {errors.username && <p className="text-red-500 text-xs">{errors.username.message}</p>}
        <label className="fieldset-label required-label">Password</label>
        <input
          type="password"
          className="input"
          placeholder="Enter your password"
          {...register("password", { required: "Password is required" })}
        />
        {errors.password && <p className="text-red-500 text-xs">{errors.password.message}</p>}

        <button className="btn btn-neutral mt-4" onClick={handleSubmit(onSubmit)}>
          Login
        </button>
      </fieldset>
    </div>
  );
};

export default LoginPage;
