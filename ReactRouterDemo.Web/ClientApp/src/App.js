import React from 'react';
import { Route } from 'react-router-dom';
import HomePage from './HomePage';
import PageOne from './PageOne';
import PageTwo from './PageTwo';

const App = () => {
    return (
        <div>
            <Route exact path='/' component={HomePage} />
            <Route exact path='/pageone' component={PageOne} />
            <Route exact path='/pagetwo' component={PageTwo} />
        </div>
    )
}

export default App;