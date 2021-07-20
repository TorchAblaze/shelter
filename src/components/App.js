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
          min-height: 100vh;
          display: flex;
          flex-direction: column;
          header,
          main,
          footer {
            width: 100%;
            max-width: 600px;
            margin: auto;
            position: relative;
          }
          header,
          footer {
            height: 100px;
            flex-shrink: 0;
            flex-direction: column;
            display: flex;
          }
          header {
            background: #ddd;
            justify-content: flex-end;
            gap: 10px;
            h1 {
              color: black;
              font-size: 40px;
            }
            nav {
              ul {
                list-style-type: none;
                display: flex;
                gap: 20px;
                li {
                  a {
                    padding: 5px 10px;
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
            flex-grow: 1;
            padding: 30px;
          }
          footer {
            justify-content: center;
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
