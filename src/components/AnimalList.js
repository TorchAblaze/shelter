/** @jsxImportSource @emotion/react */
import React from "react";
import { css } from "@emotion/react";
import { Link } from "react-router-dom";
import { useGetAllAnimalsQuery } from "../store/animalApi";

const AnimalList = () => {
  const {
    data: allAnimals,
    error: allAnimalsError,
    isLoading: allAnimalsIsLoading,
  } = useGetAllAnimalsQuery();

  console.log(`allAnimals`, allAnimals);

  if (allAnimalsIsLoading) return <div>Loading...</div>;
  if (allAnimalsError) return <div>Unable to load animals.</div>;
  return (
    <ul
      css={css`
        padding: 30px;
        display: flex;
        flex-direction: column;
        gap: 30px;
        li {
          // ul li
          margin-left: 30px;
          ~ li {
            // ul li ~ li
            border-top: 1px solid black;
            padding-top: 30px;
          }
        }
      `}
    >
      {allAnimals.map((animal, idx) => (
        <li key={idx}>
          <Link to={`/details/${animal.id}`}>{animal.name}</Link>
        </li>
      ))}
    </ul>
  );
};

export default AnimalList;
