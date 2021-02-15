import React, { useEffect, useState } from "react";
import styles from './modules/navbar.module.css';
import axios from 'axios';
import LoginButton from '../Services/LoginButton.js';
import LogoutButton from "../Services/LogoutButton.js";
import { useAuth0 } from "@auth0/auth0-react";

const Navbar = () => {
    const { user, isAuthenticated, isLoading } = useAuth0();

    return (
        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
            <div className="container-fluid">
                <a class="navbar-brand" href="#"><img id={styles.logo} src="https://i.ibb.co/JQ9mn5z/e01b7f76-5f49-4ae6-9296-846edd57ab34-200x200.png"></img></a>
            </div>
            {isAuthenticated ? <LogoutButton /> : <LoginButton />}
        </nav>
    )
}

export default Navbar;