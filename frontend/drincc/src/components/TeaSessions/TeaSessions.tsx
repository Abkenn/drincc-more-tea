import Grid from '@mui/system/Unstable_Grid';
import DailyClickableArea from '../DailyClickableArea/DailyClickableArea';

const TeaSessions: React.FunctionComponent = () => (
  <div className="tea-sessions">
    <Grid
      container
      spacing={{ xs: 0, sm: 1, md: 2 }}
      columns={{ xs: 4, sm: 4, md: 7 }}
    >
      {[...Array(7).keys()].map(() => (
        <Grid xs={1}>
          <DailyClickableArea teaSessions={[1, 2, 3]} />
        </Grid>
      ))}
    </Grid>
  </div>
);

export default TeaSessions;
