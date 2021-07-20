import animalListReducer, { defaultState } from "../../store/animalSlice.js";

describe("animalListReducer", () => {
  test("Should return default state if there is no action type passed into the slice", () => {
    expect(animalListReducer({}, { type: null })).toEqual({});
  });

  test("Requesting headlines should successfully change isLoading from false to true", () => {
    const action = {
      type: "animals/request",
    };
    console.log(animalListReducer(defaultState, action));
    expect(animalListReducer(defaultState, action)).toEqual({
      isLoading: true,
      headlines: [],
      error: null,
    });
  });
});
