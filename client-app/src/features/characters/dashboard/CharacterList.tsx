import React from "react";
import { Button, Item, Segment } from "semantic-ui-react";
import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/store/store";


export default observer(function CharacterList() {
    const {characterStore} = useStore();
    const { characters } = characterStore;
    return (
        <Segment>
            <Item.Group divided>
                {characters.map(character => (
                    <Button style={{width: '100%', margin: '2px'}}>
                    <Item key={character.id}>
                        <Item.Content>
                            <Item.Header as='a'>{character.name}</Item.Header>
                            <Item.Meta>{character.class} - {character.level}</Item.Meta>
                        </Item.Content>
                    </Item>
                    </Button>
                ))}
            </Item.Group>
        </Segment>
    );
})