import React from "react";
import { Route } from "react-router-dom";
import AnimalDetails from "./AnimalDetails.js";
import AnimalList from "./AnimalList.js";
import { Counter } from "./Counter";

const Routes = () => {
  return (
    <>
      <Route exact path="/counter">
        <Counter />
      </Route>
      <Route exact path="/">
        <div>Hi!</div>
      </Route>
      <Route exact path="/animals">
        <AnimalList />
      </Route>
      <Route exact path="/details/:id">
        <AnimalDetails />
      </Route>
    </>
  );
};

export default Routes;
