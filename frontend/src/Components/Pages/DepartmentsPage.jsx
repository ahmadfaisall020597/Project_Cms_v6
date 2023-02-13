import jwt_decode from "jwt-decode"
import React from "react"

export default function DepartmentsPage() {
    let local = JSON.parse(localStorage.getItem("userInfo"));
  let tokenUser = local.token;
  const decode = jwt_decode(tokenUser);
    console.log(decode)
    return (
        <div className=" col-span-12 min-h-[90vh] border-r border-gray-200 items-start justify-start flex flex-col w-full ">
            {/* top section*/}
            <div className="w-full items-start justify-start flex flex-col px-12 pt-3 pb-6">
                <h1 className="font-bold text-xl xl:text-2xl pb-6 "> Departments Page </h1>
                <table className="w-auto">
                    <thead>
                        <tr>
                            <th></th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
    )
}