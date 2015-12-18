var gulp = require('gulp');

var bowerdir = "./bower_components/";
var libdir = "./wwwroot/lib/";

var filesToMove = [
    bowerdir + "polymer/polymer.html"
];

gulp.task('default', ['move-polymer','move-iron-components'],function () {
});

gulp.task('move-polymer', function() {

    gulp.src(bowerdir + "polymer/*.html")
        .pipe(gulp.dest(libdir + "polymer/"));

    gulp.src(bowerdir + "webcomponentsjs/*.js")
        .pipe(gulp.dest(libdir + "webcomponentsjs/"));
});

gulp.task('move-iron-components', function() {
    gulp.src(bowerdir + "iron-*/iron-*.html")
        .pipe(gulp.dest(libdir));
});