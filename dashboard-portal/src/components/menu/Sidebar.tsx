import React, { memo } from "react";
import { Link } from "react-router-dom";

const Sidebar = () => {
  return (
    <div className=" flex flex-col">
      <h3>Sidebar</h3>
      <Link to="/category">Category Management</Link>
      <Link to="/profile">Profile Management</Link>
    </div>
  );
};

export default memo(Sidebar);
