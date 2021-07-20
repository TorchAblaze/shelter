/** @jsxImportSource @emotion/react */
import { css } from "@emotion/react";
import React from "react";
import { BrowserRouter as Router, Switch, NavLink } from "react-router-dom";
import Routes from "./Routes";

function App() {
  return (
    <Router>
      <div
        css={css`
          header,
          main,
          footer {
            width: 100%;
            max-width: 600px;
            margin: auto;
            position: relative;
          }
          header {
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
          }
          main {
            background: white;
          }
        `}
      >
        <header>
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
        <footer>Footer</footer>
      </div>
    </Router>
  );
}

export default App;
