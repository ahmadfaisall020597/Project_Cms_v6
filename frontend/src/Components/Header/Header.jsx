import React from "react";
import {
    BellIcon,
    ChipIcon,
    InboxIcon,
    SearchIcon,
    UserCircleIcon,
} from "@heroicons/react/outline";

function Header() {
    return (
        <div className=" w-full py-6 bg-[#F0F5F5] items-center justify-between flex px-12">
            {/* logo */}
            <div className="items-center w-full flex space-x-4">
                <ChipIcon className="w-6 h-6" />
                <h1 className="text-xl text-gray-900 font-medium "> Program CMS </h1>
            </div>
            {/* icons */}
            <div className="items-center justify-end space-x-6 flex w-full">
                <UserCircleIcon className="header-icon" />
                <span>Ahmad Faisal</span>
            </div>
        </div>
    );
}

export default Header;
