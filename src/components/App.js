/** @jsxImportSource @emotion/react */
import { css } from "@emotion/react";
import { BrowserRouter as Router, Switch, NavLink } from "react-router-dom";
import Routes from "./Routes";

function App() {
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
          <Routes />
        </Switch>
      </main>
      <footer></footer>
    </Router>
  );
}

export default App;
