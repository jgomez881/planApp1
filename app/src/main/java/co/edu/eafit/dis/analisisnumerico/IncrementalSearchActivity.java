package co.edu.eafit.dis.analisisnumerico;


import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;



public class IncrementalSearchActivity extends AppCompatActivity {

    private EditText expText, iterText, deltaText, iniValText, resultText;
    private Button sendBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_incremental_search);
        expText = (EditText)findViewById(R.id.expText);
        iterText = (EditText)findViewById(R.id.iterText);
        iterText = (EditText)findViewById(R.id.iterText);
        deltaText = (EditText)findViewById(R.id.deltaText);
        iniValText = (EditText)findViewById(R.id.iniValText);
        resultText = (EditText)findViewById(R.id.resultText);
        sendBtn = (Button)findViewById(R.id.sendBtn);
    }

    public void onSendClick(View view){
        String[] data = new String[4];
        data[0] = expText.getText().toString();
        data[1] = iterText.getText().toString();
        data[2] = deltaText.getText().toString();
        data[3] = iniValText.getText().toString();
        resultText.setText(IncrementalSearchUtil.incrementalSearch(data[0], Integer.parseInt(data[1]),
                Double.parseDouble(data[2]),Double.parseDouble(data[3])));
    }
}
