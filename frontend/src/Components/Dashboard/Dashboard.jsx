import Header from "../Header/Header";
import NavBar from "../SideNav/NavBar";
import LeftPart from "../LeftPart/LeftPart";
import RightPart from "../RightPart/RightPart";

export default function Dashboard() {
    return (
        <div className="App overflow-y-hidden ">
            <Header />
            <div className='w-full min-h-[90vh] grid grid-cols-12'>
                <NavBar />
                <div className='grid grid-cols-1 xl:grid-cols-5 col-span-10 w-full'>
                    <LeftPart />
                    <RightPart />
                </div>
            </div>
        </div>
    )
}