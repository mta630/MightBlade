import React, { useEffect, useState } from "react";
import LoginButton from '../Services/LoginButton.js';
import styles from './modules/navbar.module.css';
import axios from 'axios';

const Navbar = () => {

    return (
        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
            <div className="container-fluid">
                <a class="navbar-brand" href="#">MightBlade</a>
            </div>
            <LoginButton />
        </nav>
    )
}

export default Navbar;