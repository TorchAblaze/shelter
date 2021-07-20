import { configureStore } from "@reduxjs/toolkit";
import counterReducer from "./counterSlice";
import animalApi from "./animalApi";

export const store = configureStore({
  reducer: {
    counter: counterReducer,
    [animalApi.reducerPath]: animalApi.reducer,
  },
  middleware: (getDefaultMiddleware) =>
    getDefaultMiddleware().concat(animalApi.middleware),
});
