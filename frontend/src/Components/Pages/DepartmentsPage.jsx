// import jwt_decode from "jwt-decode"
import React, { useEffect, useState, useMemo } from "react"
import axios from "axios";
import { useToast, useDisclosure, Button } from "@chakra-ui/react";
import ImageEdit from '../../Assets/Images/edit.png'
import ImageDelete from '../../Assets/Images/trash.png'

export default function DepartmentsPage() {
    // let local = JSON.parse(localStorage.getItem("userInfo"));
    // let tokenUser = local.token;
    // const decode = jwt_decode(tokenUser);
    // console.log(decode)
    const [datas, setDatas] = useState([])
    const [tempId, setTempId] = useState("");
    const [isEdit, setIsEdit] = useState(false);
    const { isOpen, onOpen, onClose } = useDisclosure();
    const toast = useToast();
    const [name, setName] = useState("")
    const [manager, setManager] = useState("")

    const fetchDataDepartment = async () => {
        const result = await axios("https://localhost:44307/api/Departmens");
        setDatas(result.data.data);
    };
    useEffect(() => {
        fetchDataDepartment();
    }, [])
    console.log(datas)

    const datasElement = useMemo(() => datas.map((element, index) => {
        const onDelete = () => axios
            .delete('https://localhost:44307/api/Departmens/' + element.id)
            .then(() => {
                toast({
                    title: 'Data berhasil dihapus',
                    duration: 2000,
                    status: 'success',
                    position: 'top'
                });
                fetchDataDepartment();
            });
        const onEdit = (data) => {
            setName(data.name)
            setManager(data.manager_Id)
            onOpen();
            setIsEdit(true)
            setTempId(element.id)
        }
        return (
            <tr className="border border-2">
                <td className="text-md px-6 py-2">{index + 1}</td>
                <td className="text-md px-6 py-2">{element.name}</td>
                <td className="text-md px-6 py-2">{element.manager_Id}</td>
                <td className="border-collapse text-left flex flex-row items-center object-none h-20 w-28">
                    <Button margin="10px" colorScheme="blue" onClick={() => onEdit(element)}>{<img src={ImageEdit} />}</Button>
                    <Button margin="10px" colorScheme="red" onClick={onDelete}>{<img src={ImageDelete} />}</Button>
                </td>
            </tr>
        )
    }), [datas]);

    return (
        <div className="col-span-12 min-h-[90vh] border-r border-gray-200 items-start justify-start flex flex-col w-full">
            {/* top section*/}
            <div className="w-full items-start justify-start flex flex-col px-12 pt-3 pb-6">
                <h1 className="font-bold text-xl xl:text-2xl pb-6 "> Departments Page </h1>
                <div className="w-full items-start justify-start flex flex-col pt-3 pb-6 overflow-x-auto">
                    <table className="table-auto w-full">
                        <thead className="bg-blue-300 border border-2">
                            <th className="text-md px-6 py-2">NO</th>
                            <th className="text-md px-6 py-2">Department Name</th>
                            <th className="text-md px-6 py-2">Manager Name</th>
                            <th className="text-md px-6 py-2">Action</th>
                        </thead>
                        <tbody>
                            {datasElement}
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    )
}