const path = require('path');
const TerserPlugin = require("terser-webpack-plugin");

module.exports = {
    entry: {
        'trackprocessors': {
            import: ['@livekit/track-processors'],
            filename: 'Runtime/Plugins/livekit-trackprocessors.jspre'
        },
    },
    mode: 'production',
    devtool: 'inline-source-map',
    target: ["web"],
    module: {
        rules: [
            {
                test: /\.tsx?$/,
                use: 'ts-loader',
                exclude: /node_modules/,
            },
        ],
    },
    resolve: {
        extensions: ['.tsx', '.ts', '.js'],
    },
    optimization: {
        minimize: true,
        minimizer: [
            new TerserPlugin({
                extractComments: false,
                test: /\.jspre(\?.*)?$/i,
                terserOptions: {
                    keep_classnames: true,
                    keep_fnames: true,
                },
            }),
        ],
    },
    output: {
        globalObject: 'this',
        filename: '[name]',
        path: path.resolve(__dirname, '../'),
        library: {
            name: '[name]',
            type: 'window',
        }
    },
};