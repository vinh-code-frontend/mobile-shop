import { lazy } from "react";
import { RouteObject } from "react-router";

const NotFoundPage = lazy(() => import("@/pages/common/NotFoundPage"));

export const commonRoutes: RouteObject[] = [
  { path: "*", element: <NotFoundPage /> },
];
