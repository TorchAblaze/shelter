import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

// Define a service using a base URL and expected endpoints
const animalApi = createApi({
  reducerPath: "animalApi",
  baseQuery: fetchBaseQuery({ baseUrl: "https://localhost:5001/api/" }),
  endpoints: (builder) => ({
    getAllAnimals: builder.query({
      query: () => ``,
    }),
    getSpecificAnimal: builder.query({
      query: (id) => `animals/${id}`,
    }),
  }),
});

console.log(animalApi);

// Export hooks for usage in functional components, which are
// auto-generated based on the defined endpoints
export const { useGetAllAnimalsQuery, useGetSpecificAnimalQuery } = animalApi;

export default animalApi;
