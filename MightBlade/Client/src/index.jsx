import ReactDOM from 'react-dom';
import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import App from './Components/App.jsx';
import { Route, Link, Router, Switch, BrowserRouter } from 'react-router-dom';

const rootElement = document.getElementById('root');
// something something

const routing = (
    <BrowserRouter>
        <App />
    </BrowserRouter>
)

ReactDOM.render(routing, rootElement);