import {
  useGetAllAnimalsQuery,
  useGetSpecificAnimalQuery,
} from "../store/animalApi";

const AnimalList = () => {
  const {
    data: allAnimals,
    error: allAnimalsError,
    isLoading: allAnimalsIsLoading,
  } = useGetAllAnimalsQuery();
  const {
    data: specificAnimal,
    error: specificAnimalError,
    isLoading: specificAnimalIsLoading,
  } = useGetSpecificAnimalQuery(1);
  console.log(`allAnimals`, allAnimals);
  console.log(`allAnimalsError`, allAnimalsError);
  console.log(`allAnimalsIsLoading`, allAnimalsIsLoading);
  console.log(`specificAnimal`, specificAnimal);
  console.log(`specificAnimalError`, specificAnimalError);
  console.log(`specificAnimalIsLoading`, specificAnimalIsLoading);
  return allAnimalsIsLoading ? (
    <div>Loading...</div>
  ) : (
    <ul>
      {allAnimals.map((animal, idx) => (
        <li key={idx}>{animal.name}</li>
      ))}
    </ul>
  );
};

export default AnimalList;
