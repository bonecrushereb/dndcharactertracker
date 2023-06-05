import React from "react";
import { Grid } from "semantic-ui-react";
import { Character } from "../../../app/models/character";
import CharacterList from "./CharacterList";

interface Props {
    characters: Character[];
}

export default function CharacterDashboard({characters}: Props) {
    return (
        <Grid>
            <Grid.Column width='10'>
                <CharacterList characters={characters}/>
            </Grid.Column>
        </Grid>
    );
}