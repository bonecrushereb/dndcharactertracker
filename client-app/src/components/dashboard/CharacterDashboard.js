import { useEffect } from "react";
import PropTypes from 'prop-types';
import { connect } from 'react-redux';
import { useNavigate } from 'react-router-dom';
import { getCharacters } from "../../actions/character";
import { Button, Item, Segment } from "semantic-ui-react";


const CharacterDashboard = ({getCharacters, character: {characters}}) => {
    const navigate = useNavigate();
    useEffect(() => {
        getCharacters();
    }, [getCharacters]);
    return (
        <Segment style={{marginTop: '7em', width: '20%', marginLeft:'50px'}}>
            <h1>My Characters</h1>
            <Item.Group divided>
                {characters.map((character) => (
                    <Item key={character.id}>
                        <Item.Content>
                            <Item.Header as='a'>{character.characterName}</Item.Header>
                            <Item.Meta>{character.level} - {character.race}</Item.Meta>
                            <Item.Extra>
                                <Button onClick={() => navigate(`/characters/${character.id}`)} floated="right" content="view" style={{background: '#FF010A', color: 'white'}}/>
                            </Item.Extra>
                        </Item.Content>
                    </Item>
                ))}
            </Item.Group>
        </Segment>
    );
}

CharacterDashboard.propTypes = {
    getCharacters: PropTypes.func.isRequired,
    character: PropTypes.object.isRequired
}

const mapStateToProps = state => ({
    character: state.characterReducer
});

export default connect(mapStateToProps, {getCharacters})(CharacterDashboard);