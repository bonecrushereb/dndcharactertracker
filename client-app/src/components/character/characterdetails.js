import React, { useEffect } from 'react';
import PropTypes from 'prop-types';
import { useParams } from 'react-router-dom';
import { connect } from 'react-redux';
import { getCharacter } from '../../actions/character';


const CharacterDetails = ({ getCharacter, character: { character } }) => {
  const { id } = useParams();
  useEffect(() => {
    getCharacter(id);
  }, [getCharacter, id]);

  return (
    <section>
        <h1>{character.characterName}</h1>
        <p>{character.race} {character.level}</p>
    </section>
  );
}

CharacterDetails.propTypes = {
  getCharacter: PropTypes.func.isRequired,
  character: PropTypes.object.isRequired
}

const mapStateToProps = state => ({
  character: state.characterReducer
});

export default connect(mapStateToProps, { getCharacter })(CharacterDetails);