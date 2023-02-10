import Header from "../Dashboard/Header/Header";
import NavBar from "../Dashboard/SideNav/NavBar";
import LeftPart from "../LeftPart/LeftPart";
import RightPart from "../RightPart/RightPart"
import React, { useMemo } from "react";
import EmployeesPage from "../../Components/Pages/EmployeesPage";
import DepartmentsPage from "../../Components/Pages/DepartmentsPage";
import RolesPage from "../../Components/Pages/RolesPage";
import SettingPage from "../Pages/SettingPage";


function ThisPage() {
    return (
        <div className='grid grid-cols-1 xl:grid-cols-5 col-span-10 w-full'>
            <LeftPart />
            <RightPart />
        </div>
    )
}

export default function Dashboard(props) {
    const { slug } = props;
    const component = useMemo(() => {
        switch (slug) {
            case 'input-employees':
                return <EmployeesPage />
            case 'input-departments':
                return <DepartmentsPage />
            case 'input-roles':
                return <RolesPage />
            case 'setting':
                return <SettingPage />
            default:
                return <ThisPage />
        }
    }, [slug]);

    return (
        <div className="App overflow-y-hidden ">
            <Header />
            <div className='w-full min-h-[90vh] grid grid-cols-12'>
                <NavBar />
                <div className='grid grid-cols-1 xl:grid-cols-5 col-span-10 w-full'>
                    {component}
                </div>
            </div>
        </div>
    )
}