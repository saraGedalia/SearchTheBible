import { Route, Routes } from 'react-router-dom'
import { Home } from './Home'
import { Search } from './Search'


export const Routing = () => {
    return <>
        <Routes>
            <Route path={'/'} element={<Home></Home>}></Route>
            <Route path={'Home'} element={<Home></Home>}></Route>
            <Route path={'Search'} element={<Search></Search>}></Route>
        </Routes>
    </>
}