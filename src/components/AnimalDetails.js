/** @jsxImportSource @emotion/react */
import React from "react";
import { css } from "@emotion/react";
import { useParams } from "react-router";
import { useGetSpecificAnimalQuery } from "../store/animalApi";

const AnimalDetails = () => {
  const { id } = useParams();
  const { data: animal, error, isLoading } = useGetSpecificAnimalQuery(id);

  console.log(`AnimalDetailsData`, animal);

  if (isLoading) {
    return <div>Loading...</div>;
  }
  if (error) {
    return <div>Unable to load this animal</div>;
  }
  return (
    <div css={css``}>
      <h1>{animal.name}</h1>
      <p>
        {animal.type}: {animal.sex}
      </p>
      <p>Age: {animal.age}</p>

      {animal.available ? (
        <p>This animal is available for adoption!</p>
      ) : (
        <p>This animal is not available for adoption at this time</p>
      )}
    </div>
  );
};

export default AnimalDetails;
