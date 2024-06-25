import { GetAllBible, GetFindWord, GetCountWord, GetName } from "./api"
import { useState } from "react"
import './Style.css'


export const Search = () => {

    const [Bible, setBible] = useState([])
    const [word, setWord] = useState()

    const All = () => {
        GetAllBible()
             .then(x => {
                 setBible(x.data)
             })
    }
    const wordInBible = () => {
        GetFindWord(word)
            .then(x => {
                setBible(x.data)
            })
    }
    const count = () => {
        GetCountWord(word)
            .then(x => {
                setBible(x.data)
            })
    }
    const name = () => {
        GetName(word)
            .then(x => {
                setBible(x.data)
            })
    }

    return <>
        <div className="button">
            {<button type="text" onClick={() => All()}>להצגת כל התנ"ך</button>}<br></br><br></br>
            {<button type="text" onClick={() => wordInBible()}>חיפוש פסוקים המכילים את המילה</button>}<br></br><br></br>
            {<button type="text" onClick={() => count()}>כמות הפעמים שהמילה מופיע בתנ"ך</button>}<br></br><br></br>
            {<button type="text" onClick={() => name()}>פסוק לתפילה</button>}<br></br><br></br>
            {<input type="text" onBlur={(event) => setWord(event.target.value)}></input>}
            <br></br><br></br>
        </div>
        <header className="box">{Bible.map((c, index) => <div key={index} value={c}>{c}</div>)}</header>
    </>
}