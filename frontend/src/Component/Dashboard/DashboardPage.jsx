import React, { useState, useEffect, useMemo } from "react";
import SideNav from "./SideNav/SideNav";
import EmployeesPage from "../Pages/EmployeesPage";
import DepartmentsPage from "../Pages/DepartmentsPage";
import RolesPage from "../Pages/RolesPage";
import axios from "axios";

function ThisPage() {
    const [dashboards, setDashboards] = useState([]);
    console.log(dashboards)

    useEffect(() => {
        axios
            .get('https://localhost:44307/api/Employees')
            .then((value) => setDashboards(value.data.data))
    }, []);

    const dashboardElement = useMemo(() => dashboards.map((element) => (
        <tr>
            <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.firstName}</td>
            <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.lastName}</td>
            <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.email}</td>
            <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.phone}</td>
            <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.birthDate}</td>
            <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.gender}</td>
        </tr>
    )), [dashboards]);
    // console.log(dashboardElement)

    return (
        <div className="w-full h-full p-3 font-roboto bg-gray-100">
            <h1 className="font-roboto text-4xl text-black mb-2">Dashboard</h1>
            <div className="flex flex-row w-full bg-white p-2">
                <table className="table-auto w-full">
                    <thead>
                        <tr>
                            <th className="border-collapse border-y border-y-gray-300 text-left p-2">FirstName</th>
                            <th className="border-collapse border-y border-y-gray-300 text-left p-2">LastName</th>
                            <th className="border-collapse border-y border-y-gray-300 text-left p-2">Email</th>
                            <th className="border-collapse border-y border-y-gray-300 text-left p-2">Phone</th>
                            <th className="border-collapse border-y border-y-gray-300 text-left p-2">BirthDate</th>
                            <th className="border-collapse border-y border-y-gray-300 text-left p-2">Gender</th>
                        </tr>
                    </thead>
                    <tbody>
                        {/* {dashboards.map(dashboard => 
                            <tr>
                                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{dashboard.firstName}</td>
                                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{dashboard.lastName}</td>
                                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{dashboard.email}</td>
                                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{dashboard.phone}</td>
                                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{dashboard.birthDate}</td>
                                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{dashboard.gender}</td>
                            </tr>
                        )} */}
                        {dashboardElement}
                    </tbody>
                </table>
            </div>
        </div>
    );
}

export default function DashboardPage(props) {
    const { slug } = props;
    const component = useMemo(() => {
        switch (slug) {
            case 'input-employees':
                return <EmployeesPage />
            case 'input-department':
                return <DepartmentsPage />
            case 'input-roles':
                return <RolesPage />
            default:
                return <ThisPage />
        }
    }, [slug]);

    return (
        <div className="w-screen h-screen flex flex-row">
            <div className="w-[20%] h-full bg-blue-900">
                <SideNav />
            </div>
            <div className="w-[80%] h-full">
                {component}
            </div>
        </div>
    )
}