export default function EmployeesPage() {
    return (
        <div className=" col-span-12 min-h-[90vh] border-r border-gray-200 items-start justify-start flex flex-col w-full ">
            {/* top section*/}
            <div className="w-full items-start justify-start flex flex-col px-12 pt-3 pb-6">
                <h1 className="font-bold text-xl xl:text-2xl pb-6 "> Employees Page </h1>
                <table className="table-fixed w-full">
                    <thead className="bg-blue-300">
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">FirstName</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">LastName</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Email</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Phone</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">BirthDate</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Gender</th>
                    </thead>
                </table>
            </div>
        </div>
    )
}