import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import LoginPage from './Auth/Login/LoginPage';
import DashboardPage from './Component/Dashboard/DashboardPage';
import { Provider } from "react-redux";
import { store } from './Auth/Login/index';
import RegisterPage from './Auth/Register/Register';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <BrowserRouter>
    <Provider store={store}>  
      <Routes>
        <Route path="/" element={<LoginPage/>}/>
        <Route path="/register" element={<RegisterPage/>}/>
        <Route path="/dashboard" element={<DashboardPage />} />
        <Route path='/dashboard/input-employees' element={<DashboardPage slug="input-employees"/>} />
        <Route path='/dashboard/input-department' element={<DashboardPage slug="input-department"/>} />
        <Route path='/dashboard/input-roles' element={<DashboardPage slug="input-roles"/>} />
      </Routes>
      </Provider>
    </BrowserRouter>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
