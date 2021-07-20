/** @jsxImportSource @emotion/react */
import React from "react";
import { css } from "@emotion/react";
import { useParams } from "react-router";
import { useGetSpecificAnimalQuery } from "../store/animalApi";

const getImgUrl = (animal) => {
  if (animal.type === "cat") {
    return `https://placekitten.com/${animal.picWidth}/${animal.picHeight}`;
  } else {
    return `https://place-puppy.com/${animal.picWidth}x${animal.picHeight}`;
  }
};

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
      <img src={getImgUrl(animal)} />
      <h1>{animal.name}</h1>
      <p>
        {animal.type}: {animal.sex}
      </p>
      <p>Age: {animal.age}</p>

      {animal.available ? (
        <p>This {animal.type} is available for adoption!</p>
      ) : (
        <p>This {animal.type} is not available for adoption at this time</p>
      )}
    </div>
  );
};

export default AnimalDetails;
