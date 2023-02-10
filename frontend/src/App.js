import './App.css';
import { BrowserRouter, Routes, Route} from 'react-router-dom';
import LoginPage from './Auth/Login/LoginPage';
import RegisterPage from './Auth/Register/Register';
import Dashboard from './Components/Dashboard/Dashboard';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
          <Routes>
            <Route path="/" element={<LoginPage />} />
            <Route path="/dashboard" element={<Dashboard />} />
            <Route path="/register" element={<RegisterPage />} />
            <Route path='/dashboard/input-employees' element={<Dashboard slug="input-employees" />} />
            <Route path='/dashboard/input-departments' element={<Dashboard slug="input-departments" />} />
            <Route path='/dashboard/input-roles' element={<Dashboard slug="input-roles" />} />
            <Route path='/dashboard/setting' element={<Dashboard slug="setting" />} />
          </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
