import { Fragment, ReactElement, memo } from "react";
import Sidebar from "@/components/menu/Sidebar";
import Topbar from "@/components/menu/Topbar";
import dashboardRoutes from "@/routes/DashboardRoutes";

const checkDashboardPage = (path: string): boolean => {
  return dashboardRoutes.some((route) => route.path === path);
};

const DashboardLayout = ({
  path,
  children,
}: {
  path: string;
  children: ReactElement | null;
}) => {
  const isDashboardPage = checkDashboardPage(path);

  return isDashboardPage ? (
    <Fragment>
      <div className="flex">
        <Sidebar />
        <div>
          <Topbar />
          {children}
        </div>
      </div>
    </Fragment>
  ) : (
    children
  );
};

export default memo(DashboardLayout);
