import { CogIcon, LogoutIcon, OfficeBuildingIcon, TemplateIcon, UserIcon } from "@heroicons/react/outline";
import { BiAnalyse } from "react-icons/bi"

export const navLinks = [
  {
    id: 0,
    title: "Dashboard",
    icon: <TemplateIcon className="nav-icon" />,
    link: "/dashboard"
  },
  {
    id: 1,
    title: "Employees",
    icon: <UserIcon className="nav-icon" />,
    link: "/dashboard/input-employees"
  },
  {
    id: 2,
    title: "Department",
    icon: <OfficeBuildingIcon className="nav-icon" />,
    link: "/dashboard/input-departments",
  },
  {
    id: 3,
    title: "Roles",
    icon: <BiAnalyse className="nav-icon" />,
    link: "/dashboard/input-roles"
  },
  {
    id: 4,
    title: "Settings",
    icon: <CogIcon className="nav-icon" />,
    link: "/dashboard/setting"
  },
  {
    id: 5,
    title: "LogOut",
    icon: <LogoutIcon className="nav-icon" />,
  },
];
