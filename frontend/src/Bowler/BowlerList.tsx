import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';
import { Team } from '../types/Team';
import 'bootstrap/dist/css/bootstrap.min.css';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  type MyObject = { [key: number]: string };
  const [teamData, setTeamData] = useState<MyObject>({});

  function convertToMyObject(
    teams: { teamID: number; teamName: string }[],
  ): MyObject {
    console.log('hit convert');
    return teams.reduce((acc: MyObject, team) => {
      acc[team.teamID] = team.teamName;
      return acc;
    }, {});
  }

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5236/bowlers');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
    const fetchTeamData = async () => {
      const rsp = await fetch('http://localhost:5236/teams');
      const t = await rsp.json();
      const updatedTeamData = convertToMyObject(t);
      setTeamData(updatedTeamData);

      console.log(teamData);
    };
    fetchTeamData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowler Information</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <th>Name</th>
          <th>Team</th>
          <th>Address</th>
          <th>City</th>
          <th>State</th>
          <th>Zip</th>
          <th>Phone Number</th>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerID}>
              <td>{`${b.bowlerFirstName} ${b.bowlerMiddleInit === null ? `` : b.bowlerMiddleInit} ${b.bowlerLastName}`}</td>
              <td>{teamData[b.teamID]}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
