import Grid from '@mui/material/Unstable_Grid2';
import TeaSelect from '../../components/TeaSelect/TeaSelect';
import './index.scss';

const Teas: React.FunctionComponent = () => (
  <div className="teas">
    <Grid container spacing={{ xs: 3, md: 3, xl: 3 }} columns={{ xs: 7 }}>
      <Grid xs={1}>
        <TeaSelect />
      </Grid>
      <Grid xs={1}>
        <TeaSelect />
      </Grid>
      <Grid xs={1}>
        <TeaSelect />
      </Grid>
      <Grid xs={1}>
        <TeaSelect />
      </Grid>
      <Grid xs={1}>
        <TeaSelect />
      </Grid>
      <Grid xs={1}>
        <TeaSelect />
      </Grid>
      <Grid xs={1}>
        <TeaSelect />
      </Grid>
    </Grid>
  </div>
);

export default Teas;
