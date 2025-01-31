import { useLocation, useRoutes } from "react-router-dom";
import authRoutes from "./AuthRoutes";
import { ReactElement, Suspense, useEffect } from "react";
import { useNProgress } from "@/utils/nProgress";
import { commonRoutes } from "./CommonRoutes";
import dashboardRoutes from "./DashboardRoutes";
import DashboardLayout from "@/layouts/DashboardLayout";

export const routes = [...authRoutes, ...dashboardRoutes, ...commonRoutes];

const AppRoutes = () => {
  const { start, done } = useNProgress();
  const element: ReactElement | null = useRoutes(routes);
  const location = useLocation();

  useEffect(() => {
    start();

    done();
    return () => {
      done();
    };
  }, [location.pathname]);

  return (
    <Suspense>
      <DashboardLayout path={location.pathname}>{element}</DashboardLayout>
    </Suspense>
  );
};

export default AppRoutes;
