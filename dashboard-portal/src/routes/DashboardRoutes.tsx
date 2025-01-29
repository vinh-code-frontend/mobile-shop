import { lazy } from "react";
import { RouteObject } from "react-router";

const CategoryPage = lazy(() => import("@/pages/dashboard/CategoryPage"));
const ProfilePage = lazy(() => import("@/pages/dashboard/ProfilePage"));

const dashboardRoutes: RouteObject[] = [
  { path: "/category", element: <CategoryPage /> },
  { path: "/profile", element: <ProfilePage /> },
];

export default dashboardRoutes;
