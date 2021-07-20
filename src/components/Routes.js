import React from "react";
import { Route } from "react-router-dom";
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
    </>
  );
};

export default Routes;
