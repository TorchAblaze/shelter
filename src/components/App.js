/** @jsxImportSource @emotion/react */
import { css } from "@emotion/react";
import { Counter } from "./Counter";
import { useDispatch, useSelector } from "react-redux";
import {
  BrowserRouter as Router,
  Switch,
  Route,
  NavLink,
} from "react-router-dom";
import {
  useGetAllAnimalsQuery,
  useGetSpecificAnimalQuery,
} from "../store/animalApi";

function App() {
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
  return (
    <Router>
      <header
        css={css`
          background: #ddd;
          h1 {
            color: black;
          }
          nav {
            ul {
              list-style-type: none;
              display: flex;
              gap: 20px;
              li {
                a {
                  text-decoration: none;
                  color: #555;
                  &.active {
                    background: white;
                  }
                }
              }
            }
          }
        `}
      >
        <h1>Acapulco's Mini Animal Shelter</h1>
        <nav>
          <ul>
            <li>
              <NavLink exact to="/" activeClassName="active">
                Home
              </NavLink>
            </li>
            <li>
              <NavLink exact to="/animals" activeClassName="active">
                Adoptable Animals
              </NavLink>
            </li>
          </ul>
        </nav>
      </header>
      <main>
        <Switch>
          <Route exact path="/counter">
            <Counter />
          </Route>
          <Route exact path="/">
            <div>Hi!</div>
          </Route>
        </Switch>
      </main>
      <footer>
        <button
          type="button"
          onClick={() => {
            dispatch(requestAnimals());
          }}
        >
          Button Text
        </button>
      </footer>
    </Router>
  );
}

export default App;
