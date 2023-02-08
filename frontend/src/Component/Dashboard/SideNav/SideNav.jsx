import React from "react";
import { Accordion, AccordionButton, AccordionIcon, AccordionItem, AccordionPanel, Button } from "@chakra-ui/react";
import { useNavigate } from "react-router";
import { Link } from "react-router-dom";
import titikbuta from "../../../Assets/Images/titikbuta.jpg";

export default function SideNav() {
    const navigate = useNavigate();

    return (
        <>
            <div className="px-2 py-1">
                <img src={titikbuta}/>
            </div>
            <Accordion allowMultiple allowToggle>
                <AccordionItem className="py-1 text-white cursor-pointer" onClick={() => navigate('/dashboard')}>
                    <div className="flex flex-row items-center gap-3 py-2 text-3xl items-center justify-center">
                        <svg xmlns="http://www.w3.org/2000/svg" className="h-7 w-7" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2}>
                            <path strokeLinecap="round" strokeLinejoin="round" d="M3 12l2-2m0 0l7-7 7 7M5 10v10a1 1 0 001 1h3m10-11l2 2m-2-2v10a1 1 0 01-1 1h-3m-6 0a1 1 0 001-1v-4a1 1 0 011-1h2a1 1 0 011 1v4a1 1 0 001 1m-6 0h6" />
                        </svg>
                        Dashboard
                    </div>
                </AccordionItem>
                <AccordionItem>
                    <h2>
                        <AccordionButton className="text-white">
                            <div className="w-full flex flex-row items-center gap-4 py-4 ml-1">
                                <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2}>
                                    <path strokeLinecap="round" strokeLinejoin="round" d="M21 13.255A23.931 23.931 0 0112 15c-3.183 0-6.22-.62-9-1.745M16 6V4a2 2 0 00-2-2h-4a2 2 0 00-2 2v2m4 6h.01M5 20h14a2 2 0 002-2V8a2 2 0 00-2-2H5a2 2 0 00-2 2v10a2 2 0 002 2z" />
                                </svg>
                                Employees
                            </div>
                            <AccordionIcon />
                        </AccordionButton>
                    </h2>
                    <AccordionPanel className="text-white flex flex-col items-start gap-2 ml-7">
                        <Link to="/dashboard/input-employees">● Form Input Employees</Link>
                    </AccordionPanel>
                </AccordionItem>
                <AccordionItem>
                    <h2>
                        <AccordionButton className="text-white">
                            <div className="w-full flex flex-row items-center gap-4 py-4 ml-1">
                                <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2}>
                                    <path strokeLinecap="round" strokeLinejoin="round" d="M16 4v12l-4-2-4 2V4M6 20h12a2 2 0 002-2V6a2 2 0 00-2-2H6a2 2 0 00-2 2v12a2 2 0 002 2z" />
                                </svg>
                                Department
                            </div>
                            <AccordionIcon />
                        </AccordionButton>
                    </h2>
                    <AccordionPanel className="text-white flex flex-col items-start gap-2 ml-7">
                        <Link to="/dashboard/input-department">● Form Input Department</Link>
                    </AccordionPanel>
                </AccordionItem>
                <AccordionItem>
                    <h2>
                        <AccordionButton className="text-white">
                            <div className="w-full flex flex-row items-center gap-4 py-4 ml-1">
                                <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2}>
                                    <path strokeLinecap="round" strokeLinejoin="round" d="M3 3h2l.4 2M7 13h10l4-8H5.4M7 13L5.4 5M7 13l-2.293 2.293c-.63.63-.184 1.707.707 1.707H17m0 0a2 2 0 100 4 2 2 0 000-4zm-8 2a2 2 0 11-4 0 2 2 0 014 0z" />
                                </svg>
                                Roles
                            </div>
                            <AccordionIcon />
                        </AccordionButton>
                    </h2>
                    <AccordionPanel className="text-white flex flex-col items-start gap-2 ml-7">
                        <Link to="/dashboard/input-roles">● Form Input Roles</Link>
                    </AccordionPanel>
                </AccordionItem>
                <AccordionItem>
                    <h2>
                        <AccordionButton className="text-white">
                            <div className="w-full flex flex-row items-center gap-4 py-4 ml-1">
                                <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2}>
                                    <path strokeLinecap="round" strokeLinejoin="round" d="M10.325 4.317c.426-1.756 2.924-1.756 3.35 0a1.724 1.724 0 002.573 1.066c1.543-.94 3.31.826 2.37 2.37a1.724 1.724 0 001.065 2.572c1.756.426 1.756 2.924 0 3.35a1.724 1.724 0 00-1.066 2.573c.94 1.543-.826 3.31-2.37 2.37a1.724 1.724 0 00-2.572 1.065c-.426 1.756-2.924 1.756-3.35 0a1.724 1.724 0 00-2.573-1.066c-1.543.94-3.31-.826-2.37-2.37a1.724 1.724 0 00-1.065-2.572c-1.756-.426-1.756-2.924 0-3.35a1.724 1.724 0 001.066-2.573c-.94-1.543.826-3.31 2.37-2.37.996.608 2.296.07 2.572-1.065z" />
                                    <path strokeLinecap="round" strokeLinejoin="round" d="M15 12a3 3 0 11-6 0 3 3 0 016 0z" />
                                </svg>
                                Setting
                            </div>
                            <AccordionIcon />
                        </AccordionButton>
                    </h2>
                    {/* <AccordionPanel className="text-white flex flex-col items-start gap-2 ml-7">
                        <Link to="/dashboard/pengaturan-user">● Change Password</Link>
                        {
                            'user'
                                ?
                                <Button variant="primary" size="lg" onClick=''>
                                    Logout
                                </Button>
                                : null
                        }
                    </AccordionPanel> */}
                </AccordionItem>
            </Accordion>
        </>
    )
}