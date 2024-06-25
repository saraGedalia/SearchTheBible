import './Style.css'
import { NavLink } from 'react-router-dom'

export const Nav = () => {
    return <>
        <div className={'nav'}>
            <NavLink to='Home' className={'link'}>Welcome</NavLink>
            <NavLink to='Search' className={'link'}>SearchTheBible</NavLink>
        </div>
    </>
}