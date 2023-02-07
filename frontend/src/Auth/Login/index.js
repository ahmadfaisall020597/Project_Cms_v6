import { configureStore } from "@reduxjs/toolkit";
import authReducer from "../Login/authslice";

export const store = configureStore({
  reducer: {
    auth: authReducer,
  },
});