import './App.css';
import { BrowserRouter, Routes, Route} from 'react-router-dom';
import LoginPage from './Auth/Login/LoginPage';
import DashboardPage from './Component/Dashboard/DashboardPage';
import RegisterPage from './Auth/Register/Register';
import Dashboard from './Components/Dashboard/Dashboard';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
          <Routes>
            <Route path="/" element={<LoginPage />} />
            <Route path="/dashboards" element={<Dashboard />} />
            <Route path="/register" element={<RegisterPage />} />
            <Route path="/dashboard" element={<DashboardPage />} />
            <Route path='/dashboard/input-employees' element={<DashboardPage slug="input-employees" />} />
            <Route path='/dashboard/input-department' element={<DashboardPage slug="input-department" />} />
            <Route path='/dashboard/input-roles' element={<DashboardPage slug="input-roles" />} />
          </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
