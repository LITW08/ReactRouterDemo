import React from 'react';
import { Link } from 'react-router-dom';

export default function Home(){
    return (
        <div>
        <h1>Home Page</h1>
        <Link to='/pageone'>
            Page One
        </Link>
        <Link to='/pagetwo'>
            Page Two
        </Link>
        </div>
    )
}