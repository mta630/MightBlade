import ReactDOM from 'react-dom';
import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import App from './Components/App.jsx';
import { Route, Link, Router, Switch, BrowserRouter } from 'react-router-dom';
import { Auth0Provider } from "@auth0/auth0-react";

const rootElement = document.getElementById('root');

const routing = (
    <Auth0Provider
    domain="mightblade.us.auth0.com"
    clientId="mlMozsn5pgP5tJ5MbaTQag65afX3k1pr"
    redirectUri={window.location.origin}>
        <BrowserRouter>
            <App />
        </BrowserRouter>
    </Auth0Provider>

)

ReactDOM.render(routing, rootElement);