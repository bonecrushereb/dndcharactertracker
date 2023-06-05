import React from "react";
import { Container, Grid } from "semantic-ui-react";
import CharacterList from "./CharacterList";
import { observer } from "mobx-react-lite";


export default observer(function CharacterDashboard() {
    return (
        <Container style={{marginTop: '7em'}}>
            <Grid>
                <Grid.Column width='10'>
                    <CharacterList />
                </Grid.Column>
            </Grid>
        </Container>
    );
})