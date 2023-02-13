import { useToast, useDisclosure, Button } from "@chakra-ui/react"
import axios from "axios"
import React, { useState, useMemo } from "react"
import ImageEdit from '../../Assets/Images/edit.png'
import ImageDelete from '../../Assets/Images/trash.png'

export default function EmployeesPage() {
    const [datas, setDatas] = useState([])
    const toast = useToast();
    const [error, setError] = useState(false)
    const [isEdit, setIsEdit] = useState(false);
    const { isOpen, onOpen, onClose } = useDisclosure();
    const modalClose = () => {
        clearForm();
        onClose();
    }
    const [tempId, setTempId] = useState("");
    const [nik, setNik] = useState("")
    const [firstname, setFirtsname] = useState("")
    const [lastname, setLastname] = useState("")
    const [phone, setPhone] = useState("")
    const [birthdate, setBirthdate] = useState("")
    const [email, setEmail] = useState("")
    const [salary, setSalary] = useState("")
    const [gender, setGender] = useState("")


    // useEffect(() => {
    const fetchData = async () => {
        const result = await axios("https://localhost:44307/api/Employees");
        setDatas(result.data.data);
    };
    fetchData();
    // }, []);
    console.log(datas)

    function formatDate(BirthDate) {
        var d = new Date(BirthDate);
        const months = {
            0: 'January',
            1: 'February',
            2: 'March',
            3: 'April',
            4: 'May',
            5: 'June',
            6: 'July',
            7: 'August',
            8: 'September',
            9: 'October',
            10: 'November',
            11: 'December',
        }
        const days = ['Minggu', 'Senin', 'Selasa', 'Rabu', 'Kamis', "Jum'at", 'Sabtu']
        const year = d.getFullYear()
        const date = d.getDate()
        const monthIndex = d.getMonth()
        const monthName = months[d.getMonth()]
        const dayName = days[d.getDay()]
        const hours = d.getHours()
        const minutes = d.getMinutes()
        const formatted = `${dayName}, ${date} ${monthName} ${year}, ${hours} : ${minutes}`
        return formatted.toString()
    }

    const clearForm = () => {
        setNik("")
        setFirtsname("")
        setLastname("")
        setPhone("")
        setBirthdate("")
        setEmail("")
        setSalary("")
        setGender("")
    }

    const datasElement = useMemo(() => datas.map((element, index) => {
        const onDelete = () => axios
            .delete('https://localhost:44307/api/Employees/' + element.id)
            .then(() => {
                toast({
                    title: 'Data berhasil dihapus',
                    duration: 2000,
                    status: 'success',
                    position: 'top'
                });
                fetchData();
            });
        const onEdit = (data) => {
            setNik(data.nik)
            setFirtsname(data.firstName)
            setLastname(data.lastName)
            setPhone(data.phone)
            setBirthdate(data.birthDate)
            setEmail(data.email)
            setSalary(data.salary)
            setGender(data.gender)
            onOpen();
            setIsEdit(true)
            setTempId(element.id)
        }
        return (
            <tr>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{index + 1}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.nik}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.firstName}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.lastName}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.phone}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{formatDate(element.birthDate)}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.email}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.salary}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left p-2">{element.gender}</td>
                <td className="border-collapse border-y border-y-gray-300 text-left flex flex-row items-center">
                    <Button margin="10px" colorScheme="blue" onClick={() => onEdit(element)}>{<img src={ImageEdit} />}</Button>
                    <Button margin="10px" colorScheme="red" onClick={onDelete}>{<img src={ImageDelete} />}</Button>
                </td>
            </tr>
        )
    }), [datas]);

    const onTambahData = () => {
        setIsEdit(false);
        onOpen();
    }

    return (
        <div className=" col-span-12 min-h-[90vh] border-r border-gray-200 items-start justify-start flex flex-col w-full ">
            {/* top section*/}
            <div className="w-full items-start justify-start flex flex-col px-12 pt-3 pb-6">
                <h1 className="font-bold text-xl xl:text-2xl pb-6 "> Employees Page </h1>
                <table className="table-fixed w-full overflow-x-scroll">
                    <thead className="bg-blue-300 overflow-x-scroll">
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">NO</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">NIK</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">FirstName</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">LastName</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Phone</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Birtdate</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Email</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Salary</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Gender</th>
                        <th className="border-collapse border-y border-y-gray-300 text-left p-2">Action</th>
                    </thead>
                    <tbody>
                        {datasElement}
                    </tbody>
                </table>
            </div>
        </div>
    )
}