import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    NIK: 0,
    RoleId: 0,
    Email:"",
    Token: "",
    RoleName:""
};
const authSlice = createSlice({
    name: "auth",
    initialState,
    reducers: {
        login: (state, action) => {
            // action : { type: "auth/login",  payload : {id, username, name, email, password} }
            state.NIK = action.payload.NIK;
            state.Email = action.payload.Email
            state.RoleId = action.payload.RoleId;
            state.Token = action.payload.Token
            state.RoleName = action.RoleName
        },
        logout: (state) => {
            state.NIK = initialState.id;
            state.Email = initialState.Email;
            state.RoleId = initialState.RoleId
            state.Token = initialState.Token
            state.RoleName = initialState.RoleName
        },
    },
});

export const { login, logout } = authSlice.actions;

export default authSlice.reducer;