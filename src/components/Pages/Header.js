import React from 'react'
import { Link } from 'react-router-dom'

export default function Header() {

    return (
        <header>
            <div className='container'>
                <div id='branding'>
                    <h1><span className='highlight'>Welcome </span>to Employee UI</h1>
                    {/* <Link to="/">Home</Link>| <Link to="/About">About </Link> */}
                </div>
                <div className="header-ul-box">
                    <ul>
                        <li className='current'> <Link to="/">Home</Link></li>
                        <li> <Link to="/About">About </Link></li>
                    </ul>
                </div>
            </div>
        </header>
    )
}