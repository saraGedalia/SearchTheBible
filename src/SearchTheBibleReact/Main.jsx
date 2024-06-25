import { Nav } from "./Nav";
import { BrowserRouter } from "react-router-dom";
import { Routing } from "./Routing";

export const Main = () => {
    debugger
    return <>
        <BrowserRouter>
            <Nav></Nav>
            <Routing></Routing>
        </BrowserRouter>
    </>
}